import React, { Fragment } from "react";
import {
  Box,
  FormControl,
  InputLabel,
  MenuItem,
  Select,
  TextField,
} from "@mui/material";
import { DatePicker } from "@mui/x-date-pickers";
import { Controller, useFormContext } from "react-hook-form";
import {
  ALLOWED_MONTH_DAYS,
  MONTHS,
  REPEAT_DAILY,
  REPEAT_MONTHLY,
  REPEAT_ONLY_ONCE,
  REPEAT_WEEKLY,
  REPEAT_YEARLY,
} from "../../../../constants/schedule";
import dayjs from "dayjs";

const RepeatInputFactory = ({ repeat, disabled }) => {
  const { control } = useFormContext();

  return (
    <Fragment>
      <Controller
        name="repeatDetails.onlyOnce"
        control={control}
        disabled={disabled}
        render={({ field: { onChange, value, ...field }, fieldState }) =>
          REPEAT_ONLY_ONCE === repeat && (
            <DatePicker
              label="Date"
              value={value ? dayjs(value) : null} // Ensure value is a valid Day.js object
              onChange={(newValue) => {
                onChange(newValue); // Update with Day.js object or null
              }}
              renderInput={(params) => (
                <TextField
                  fullWidth
                  {...params}
                  error={!!fieldState.error}
                  helperText={
                    fieldState.error ? fieldState.error.message : null
                  }
                />
              )}
              {...field}
            />
          )
        }
      />

      <Controller
        name="repeatDetails.weekly"
        control={control}
        disabled={disabled}
        render={({ field }) =>
          REPEAT_WEEKLY === repeat && (
            <FormControl>
              <InputLabel id="week">Every week on</InputLabel>
              <Select
                labelId="week"
                label="Every week on"
                {...field}
                value={field.value || ""}
              >
                {[
                  "monday",
                  "tuesday",
                  "wednesday",
                  "thursday",
                  "friday",
                  "saturday",
                  "sunday",
                ].map((day) => (
                  <MenuItem key={day} value={day}>
                    {day.charAt(0).toUpperCase() + day.slice(1)}
                  </MenuItem>
                ))}
              </Select>
            </FormControl>
          )
        }
      />

      <Controller
        name="repeatDetails.monthly"
        control={control}
        disabled={disabled}
        render={({ field }) =>
          REPEAT_MONTHLY === repeat && (
            <FormControl>
              <InputLabel id="month">Every month on</InputLabel>
              <Select
                labelId="month"
                label="Every month on"
                {...field}
                value={field.value || ""}
              >
                {ALLOWED_MONTH_DAYS.map((day, idx) => (
                  <MenuItem key={idx} value={day}>
                    {day}
                  </MenuItem>
                ))}
              </Select>
            </FormControl>
          )
        }
      />

      <Controller
        name="repeatDetails.yearly"
        control={control}
        disabled={disabled}
        render={({ field }) =>
          REPEAT_YEARLY === repeat && (
            <FormControl>
              <InputLabel id="year">Every year on</InputLabel>
              <Select
                labelId="year"
                label="Every year on"
                {...field}
                value={field.value || ""} // Ensure value is controlled
              >
                {MONTHS.map((month, idx) => (
                  <MenuItem key={idx} value={month}>
                    {month}
                  </MenuItem>
                ))}
              </Select>
            </FormControl>
          )
        }
      />
    </Fragment>
  );
};

export default RepeatInputFactory;
