import React from "react";
import { Fragment } from "react";
import { convertToTimeFormat } from "../components/PlaygroundOverview/Calendar/helpers";
import SessionCell from "../components/PlaygroundOverview/Calendar/SessionCell";

const DayRow = ({ hour, sessionData }) => {
  const formattedHour = convertToTimeFormat(hour);

  return (
    <Fragment>
      <div className="cell">{formattedHour}</div>
      {!sessionData?.isCovered && <SessionCell session={sessionData} />}
    </Fragment>
  );
};

export default DayRow;
