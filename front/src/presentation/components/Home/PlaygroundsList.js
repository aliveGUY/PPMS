import React from "react";
import { Stack, Typography } from "@mui/material";
import PlaygroundListItem from "../../common/PlaygroundListItem";

const PlaygroundsList = () => {
  return (
    <Stack spacing={2}>
      <Typography variant="h6" p={3}>
        Dummy Data
      </Typography>
      <PlaygroundListItem />
      <PlaygroundListItem />
      <PlaygroundListItem />
      <PlaygroundListItem />
      <PlaygroundListItem />
    </Stack>
  );
};

export default PlaygroundsList;
