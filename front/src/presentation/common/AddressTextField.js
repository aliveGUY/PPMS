import React, { useCallback } from "react";
import { useGeocodeMutation } from "../../state/api/geoCodeApi";
import { rememberAddressInputValue } from "../../state/slice/geoCodeSlice";
import { useDispatch } from "react-redux";
import { IconButton, OutlinedInput } from "@mui/material";
import SearchIcon from "@mui/icons-material/Search";

const AddressTextField = () => {
  const dispatch = useDispatch();
  const [geocode] = useGeocodeMutation();

  const handleInputChange = useCallback((e) => {
    geocode(e.target.value);
    dispatch(rememberAddressInputValue(e.target.value));
  }, []);

  return (
    <OutlinedInput
      onChange={handleInputChange}
      placeholder="Enter street address"
      endAdornment={
        <IconButton color="primary">
          <SearchIcon />
        </IconButton>
      }
    />
  );
};

export default AddressTextField;
