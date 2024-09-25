import React from "react";
import { Box, Button, Stack, Typography } from "@mui/material";
import defaultImage from "../../../static/images/no_image_playground.png";
import PlaygroundOverviewTab from "../../common/PlaygroundOverviewTab";
import { useSelector } from "react-redux";

const Header = () => {
  const { name, address, id } = useSelector(
    (state) => state.playgrounds.currentPlayground
  );

  const image = defaultImage;

  return (
    <Box>
      <Box
        mt={3}
        sx={{
          width: "100%",
          height: 218,
          backgroundImage: `url(${image})`,
          backgroundPosition: "center",
          backgroundRepeat: "no-repeat",
          backgroundSize: "cover",
          borderRadius: "12px",
        }}
      />
      <Stack direction="row" alignItems="center" pt={3} pb={2}>
        <Box flex={1}>
          <Typography variant="h4" fontWeight={600} marginBottom="12px">
            {name}
          </Typography>
          <Typography fontSize="14px" color="#4F7A94">
            {address}
          </Typography>
        </Box>
        <Box>
          <Button variant="outlined">Add To Favourite</Button>
        </Box>
      </Stack>
      <Stack direction="row" px={2} borderBottom="1px solid #D1DEE5">
        <PlaygroundOverviewTab to={`/playground/${id}`} text="Calendar" />
        <PlaygroundOverviewTab
          to={`/playground/${id}/votings`}
          text="Votings"
        />
        <PlaygroundOverviewTab
          to={`/playground/${id}/history`}
          text="Event History"
        />
      </Stack>
    </Box>
  );
};

export default Header;
