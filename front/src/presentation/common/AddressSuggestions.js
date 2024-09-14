import React from "react";
import { useSelector } from "react-redux";

const AddressSuggestions = () => {
  const addressSuggestions = useSelector(
    (state) => state.geoCodeData.addressSuggestions
  );
  return (
    <div>
      {addressSuggestions.map((suggestion) => (
        <div>{suggestion}</div>
      ))}
    </div>
  );
};

export default AddressSuggestions;
