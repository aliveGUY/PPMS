import React from "react";
import AddressSuggestions from "../common/AddressSuggestions";
import AddressTextField from "../common/AddressTextField";
import { Stack } from "@mui/material";
import { inputBaseClasses } from "@mui/material/InputBase";

const AddressInput = () => {
  return (
    <Stack
      sx={{
        position: "relative",
        [`.${inputBaseClasses.root}`]: {
          backgroundColor: "white",
        },
      }}
    >
      <AddressTextField />
      <AddressSuggestions />
    </Stack>
  );
};

export default AddressInput;
