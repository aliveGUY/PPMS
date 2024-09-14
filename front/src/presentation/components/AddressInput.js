import React, { Fragment } from "react";
import AddressSuggestions from "../common/AddressSuggestions";
import AddressTextField from "../common/AddressTextField";

const AddressInput = () => {
  return (
    <Fragment>
      <AddressTextField />
      <AddressSuggestions />
    </Fragment>
  );
};

export default AddressInput;
