import { Paper } from "@mui/material";
import React from "react";
import { useSelector } from "react-redux";

const AddressSuggestions = () => {
  const addressSuggestions = useSelector(
    (state) => state.geoCodeData.addressSuggestions
  );

  if (!addressSuggestions || addressSuggestions.length === 0) return;

  return (
    <Paper
      sx={{
        position: "absolute",
        top: "50px",
        padding: 2,
        right: 0,
        left: 0,
      }}
    >
      {addressSuggestions.map((suggestion) => (
        <div>{suggestion}</div>
      ))}
    </Paper>
  );
};

export default AddressSuggestions;
