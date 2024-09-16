import React from "react";
import { Stack, Typography } from "@mui/material";
import AddressInput from "../../common/AddressInput";

const Header = () => {
  return (
    <Stack>
      <Typography>Find playground</Typography>
      <AddressInput />
    </Stack>
  );
};

export default Header;
