import React from "react";
import DayView from "./DayView";
import ScheduleModal from "./ScheduleModal";
import CalendarHeader from "./CalendarHeader";
import { Box } from "@mui/material";
import dayjs from "dayjs";
import utc from "dayjs/plugin/utc";

dayjs.extend(utc);

const schedule = [
  {
    title: "morning session",
    startAt: dayjs.utc("0000-01-01T08:00:00Z").toISOString(),
    finishAt: dayjs.utc("0000-01-01T09:00:00Z").toISOString(),
  },
  {
    title: "stretch",
    startAt: dayjs.utc("0000-01-01T09:00:00Z").toISOString(),
    finishAt: dayjs.utc("0000-01-01T12:00:00Z").toISOString(),
  },
  {
    title: "game",
    startAt: dayjs.utc("0000-01-01T16:00:00Z").toISOString(),
    finishAt: dayjs.utc("0000-01-01T20:00:00Z").toISOString(),
  },
];

const Calendar = () => {
  return (
    <Box position="relative">
      <ScheduleModal />
      <CalendarHeader />
      <DayView schedule={schedule} />
    </Box>
  );
};

export default Calendar;
