import React, { useState } from "react";
import { FormControl, InputLabel, MenuItem, Select } from "@mui/material";
import moment from "moment-timezone";

const timezones = moment.tz.names();

const TimezoneInput = () => {
  const [selectedTimezone, setSelectedTimezone] = useState("UTC");

  const handleTimezoneChange = (event) => {
    setSelectedTimezone(event.target.value);
  };

  return (
    <FormControl>
      <InputLabel id="timezone">Your timezone</InputLabel>
      <Select
        id="timezone"
        label="Your timezone"
        value={selectedTimezone}
        onChange={handleTimezoneChange}
        sx={{
          minWidth:200
        }}
      >
        {timezones.map((timezone) => (
          <MenuItem key={timezone} value={timezone}>
            {timezone}
          </MenuItem>
        ))}
      </Select>
    </FormControl>
  );
};

export default TimezoneInput;
