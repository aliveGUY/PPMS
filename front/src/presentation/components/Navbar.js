import React from "react";
import { Typography, Link as MuiLink, Stack } from "@mui/material";
import Grid from "@mui/material/Grid2";

import { Link } from "react-router-dom";

const Navbar = () => {
  return (
    <Grid
      container
      height={65}
      borderBottom="1px solid #E5E8EB"
      alignItems="center"
    >
      <Grid flex={1}>
        <Typography>Playgrounds</Typography>
      </Grid>
      <Grid flex={1}>
        <Stack direction="row" justifyContent="end" spacing={3}>
          <MuiLink component={Link}>Home</MuiLink>
          <MuiLink component={Link}>Favourites</MuiLink>
          <MuiLink component={Link}>Profile</MuiLink>
        </Stack>
      </Grid>
    </Grid>
  );
};

export default Navbar;
