import { Button, Paper, Stack } from "@mui/material";
import React from "react";
import { useDispatch, useSelector } from "react-redux";
import { useGetPlaygroundsMutation } from "../../state/api/backendApi";
import { rememberSearchParams } from "../../state/slice/playgroundsSlice";
import { clearAddressState } from "../../state/slice/geoCodeSlice";

const AddressSuggestions = () => {
  const [getPlaygrounds] = useGetPlaygroundsMutation();
  const dispatch = useDispatch();
  const addressSuggestions = useSelector(
    (state) => state.geoCodeData.addressSuggestions
  );

  if (!addressSuggestions || addressSuggestions.length === 0) return;

  const searchPlaygrounds = (suggestion) => {
    const {
      title,
      address: { countryName, country, city, street },
    } = suggestion;

    const params = {
      address: title,
      city: city,
      province: country,
      country: countryName,
      street: street,
    };

    getPlaygrounds(params);
    dispatch(rememberSearchParams(params));
    dispatch(clearAddressState());
  };

  return (
    <Paper
      sx={{
        position: "absolute",
        top: "60px",
        padding: "16px 8px",
        right: 0,
        left: 0,
        zIndex: 10,
      }}
    >
      <Stack>
        {addressSuggestions.map((suggestion, key) => (
          <Button
            key={key}
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
