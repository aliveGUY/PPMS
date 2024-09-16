import React, { useCallback } from "react";
import { useGeocodeMutation } from "../../state/api/geoCodeApi";
import { rememberAddressInputValue } from "../../state/slice/geoCodeSlice";
import { useDispatch } from "react-redux";
import { FilledInput } from "@mui/material";

const AddressTextField = () => {
  const dispatch = useDispatch();
  const [geocode] = useGeocodeMutation();

  const handleInputChange = useCallback((e) => {
    geocode(e.target.value);
    dispatch(rememberAddressInputValue(e.target.value));
  }, []);

  return (
    <FilledInput
      onChange={handleInputChange}
      id="filled-basic"
      placeholder="Enter Address"
      variant=""
    />
  );
};

export default AddressTextField;
