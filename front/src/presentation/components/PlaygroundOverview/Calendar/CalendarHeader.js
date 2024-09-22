import { Box, Button, Divider, Stack } from "@mui/material";
import React, { useCallback } from "react";
import TimezoneInput from "../../../common/TimezoneInput";
import { useDispatch } from "react-redux";
import { openCreateScheduleModal } from "../../../../state/slice/scheduleModalSlice";

const CalendarHeader = () => {
  const dispatch = useDispatch();

  const openModal = useCallback(() => {
    dispatch(openCreateScheduleModal());
  }, []);

  return (
    <Box position="sticky" top={0} mb={3} backgroundColor="white">
      <Stack direction="row" py={2} spacing={2}>
        <TimezoneInput />
        <Button variant="contained" onClick={openModal}>
          Schedule new session
        </Button>
      </Stack>
      <Divider />
    </Box>
  );
};

export default CalendarHeader;
