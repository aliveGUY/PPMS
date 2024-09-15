import React, { useCallback } from "react";
import { useGeocodeMutation } from "../../state/api/geoCodeApi";
import { rememberAddressInputValue } from "../../state/slice/geoCodeSlice";
import { useDispatch } from "react-redux";

const AddressTextField = () => {
  const dispatch = useDispatch();
  const [geocode, { isLoading }] = useGeocodeMutation();

  const handleInputChange = useCallback((e) => {
    geocode(e.target.value);
    dispatch(rememberAddressInputValue(e.target.value));
  }, []);

  return (
    <div>
      <input onChange={handleInputChange} type="text" />
      {isLoading && <span>loading</span>}
    </div>
  );
};

export default AddressTextField;
