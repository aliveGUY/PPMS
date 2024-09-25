import React from "react";
import { Stack } from "@mui/material";
import PlaygroundListItem from "../../common/PlaygroundListItem";
import { useSelector } from "react-redux";
import NotFoundBanner from "./NotFoundBanner";

const PlaygroundsList = () => {
  const playgroundsData = useSelector((state) => state.playgrounds);
  const { playgrounds } = playgroundsData;

  const isEmpty = playgrounds.length === 0;

  return (
    <Stack spacing={2} py={2}>
      {isEmpty && <NotFoundBanner />}
      {!isEmpty &&
        playgrounds.map((playground, key) => (
          <PlaygroundListItem playground={playground} key={key} />
        ))}
    </Stack>
  );
};

export default PlaygroundsList;
