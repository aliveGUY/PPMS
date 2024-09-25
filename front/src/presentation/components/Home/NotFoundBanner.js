import React from "react";
import { Box, Button, Paper, Stack, Typography } from "@mui/material";
import { useNavigate } from "react-router-dom";
import { useSelector } from "react-redux";

const NotFoundBanner = () => {
  const playgroundsData = useSelector((state) => state.playgrounds);
  const { scope, searchParams } = playgroundsData;

  const navigate = useNavigate();

  const title = {
    all: `It seem like theres no Registered Playgrounds at all`,
    city: `It seem like theres no Registered Playgrounds in ${searchParams.city}`,
    province: `It seem like theres no Registered Playgrounds in ${searchParams.province}`,
    country: `It seem like theres no Registered Playgrounds in ${searchParams.country}`,
  }[scope];

  const subtitle = {
    all: `Register first Playground?`,
    city: `Register Playground in ${searchParams.city}?`,
    province: `Register Playground in ${searchParams.province}?`,
    country: `Register Playground in ${searchParams.country}?`,
  }[scope];

  return (
    <Paper
      sx={{ padding: 3, backgroundColor: "#FFC55A", borderRadius: "12px" }}
    >
      <Stack alignItems="center" spacing={2}>
        <Stack alignItems="center">
          <Typography fontWeight={700} variant="h6">
            {title}
          </Typography>
          <Typography>{subtitle}</Typography>
        </Stack>
        <Button onClick={() => navigate("playground/new")} variant="outlined">
          Register
        </Button>
      </Stack>
    </Paper>
  );
};

export default React.memo(NotFoundBanner);
