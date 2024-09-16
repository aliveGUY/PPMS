import React from "react";
import { Paper, Stack, Typography } from "@mui/material";
import AddressInput from "../../common/AddressInput";

import heroImage from "../../../static/images/hero.png";

const Header = () => {
  return (
    <Paper
      sx={{
        marginTop: 3,
        backgroundImage: `url(${heroImage})`,
        backgroundPosition: "center",
        padding: 4,
        borderRadius: "16px",
      }}
    >
      <Stack maxWidth={800} mx="auto" spacing={2}>
        <Typography
          variant="h3"
          fontWeight={700}
          color="white"
          textAlign="center"
        >
          Welcome to Playgrounds
        </Typography>
        <AddressInput />
      </Stack>
    </Paper>
  );
};

export default Header;
