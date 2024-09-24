import React from "react";
import { Button, Stack, Typography } from "@mui/material";
import PlaygroundListItem from "../../common/PlaygroundListItem";
import { useSelector } from "react-redux";

const PlaygroundsList = () => {
  const playgroundsData = useSelector((state) => state.playgrounds);
  const { playgrounds, scope, searchParams } = playgroundsData;

  const isEmpty = playgrounds.length === 0;

  const title = {
    all: `It seem like theres no Registered Playgrounds at all`,
    city: `It seem like theres no Registered Playgrounds in ${searchParams.city}`,
    province: `It seem like theres no Registered Playgrounds in ${searchParams.province}`,
    country: `It seem like theres no Registered Playgrounds in ${searchParams.country}`,
  }[scope];

  const subtitle = {
    all: `Register new Playground?`,
    city: `Register new Playground in ${searchParams.city}?`,
    province: `Register new Playground in ${searchParams.province}?`,
    country: `Register new Playground in ${searchParams.country}?`,
  }[scope];

  return (
    <Stack spacing={2}>
      <Typography variant="h6" p={3}>
        {title}
      </Typography>

      {isEmpty && <Button variant="contained">{subtitle}</Button>}

      {!isEmpty && playgrounds.map(() => <PlaygroundListItem />)}
    </Stack>
  );
};

export default PlaygroundsList;
