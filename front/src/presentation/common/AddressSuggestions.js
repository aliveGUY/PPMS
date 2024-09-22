import { Button, Paper, Stack } from "@mui/material";
import React, { useCallback } from "react";
import { useSelector } from "react-redux";
import { useGetPlaygroundsMutation } from "../../state/api/backendApi";

const SuggestionButton = ({ onClick, suggestion, children, ...props }) => {
  const handleClick = useCallback(() => onClick(suggestion), []);
  return (
    <Button onClick={handleClick} {...props}>
      {children}
    </Button>
  );
};

const AddressSuggestions = () => {
  const [getPlaygrounds] = useGetPlaygroundsMutation();
  const addressSuggestions = useSelector(
    (state) => state.geoCodeData.addressSuggestions
  );

  if (!addressSuggestions || addressSuggestions.length === 0) return;

  const searchPlaygrounds = (suggestion) => {
    const {
      title,
      address: { countryName, country, city, state },
    } = suggestion;

    console.log({ countryName, country, city, state });
    console.log({ suggestion });
    getPlaygrounds({
      title,
      country: country || countryName,
      city,
      state,
    });
  };

  return (
    <Paper
      sx={{
        position: "absolute",
        top: "60px",
        padding: "16px 8px",
        right: 0,
        left: 0,
      }}
    >
      <Stack>
        {addressSuggestions.map((suggestion) => (
          <Button
            onClick={() => searchPlaygrounds(suggestion)}
            sx={{ justifyContent: "start", color: "black" }}
          >
            {suggestion.title}, {suggestion.address.countryName}
          </Button>
        ))}
      </Stack>
    </Paper>
  );
};

export default AddressSuggestions;
