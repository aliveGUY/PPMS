import React, { useCallback } from "react";
import { Box, Paper, Typography } from "@mui/material";
import { convertToTimeFormat, getHour } from "./helpers";
import { openEditScheduleModal } from "../../../../state/slice/scheduleModalSlice";
import { useDispatch } from "react-redux";

const SessionCell = ({ session }) => {
  const dispatch = useDispatch();

  if (!session) return <div className="cell" />;

  const startHour = getHour(session.startAt);
  const endHour = getHour(session.finishAt);
  const rowSpan = endHour - startHour;

  const openModal = useCallback(() => {
    dispatch(openEditScheduleModal(session));
  }, []);

  return (
    <div className="cell" style={{ gridRow: `span ${rowSpan}` }}>
      <Box py={0.5} height="100%">
        <Paper
          onClick={openModal}
          sx={{
            cursor: "pointer",
            height: "100%",
            backgroundColor: "#A7C7E7",
            "&:hover": {
              boxShadow: 6,
            },
          }}
        >
          <Box px={1}>
            <Typography fontSize={{ xs: 14, md: 20 }} fontWeight={600}>
              {session.title}
            </Typography>
            <Typography>
              {convertToTimeFormat(startHour)} - {convertToTimeFormat(endHour)}
            </Typography>
          </Box>
        </Paper>
      </Box>
    </div>
  );
};

export default SessionCell;
