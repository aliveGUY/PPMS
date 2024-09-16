import React from "react";
import AddressSuggestions from "../common/AddressSuggestions";
import AddressTextField from "../common/AddressTextField";
import { Stack } from "@mui/material";

const AddressInput = () => {
  return (
    <Stack sx={{ position: "relative" }}>
      <AddressTextField />
      <AddressSuggestions />
    </Stack>
  );
};

export default AddressInput;
