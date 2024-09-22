import React from "react";
import { mapSchedule } from "./helpers";
import DayRow from "../../../common/DayRow";

const HOURS = [
  1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22,
  23, 24,
];

const DayView = ({ schedule }) => {
  const mappedSchedule = mapSchedule(schedule);

  return (
    <div className="calendar-day">
      {HOURS.map((hour, idx) => (
        <DayRow key={idx} hour={hour} sessionData={mappedSchedule[hour]} />
      ))}
    </div>
  );
};

export default DayView;
