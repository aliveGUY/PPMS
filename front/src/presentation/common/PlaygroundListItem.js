import { Box, Paper, Stack, Typography } from "@mui/material";
import React, { useCallback } from "react";
import defaultImage from "../../static/images/no_image_playground.png";
import { useNavigate } from "react-router-dom";

const PlaygroundListItem = ({ playground }) => {
  const { address, images, name, id } = playground;
  const image = images[0] || defaultImage;

  const navigate = useNavigate();

  const redirect = useCallback(() => {
    navigate(`/playground/${id}`);
  }, [navigate]);

  return (
    <Paper
      elevation={0}
      onClick={redirect}
      sx={{
        padding: 1,
        borderRadius: "12px",
        cursor: "pointer",
        "&:hover": {
          boxShadow: 6,
        },
      }}
    >
      <Stack direction="row" spacing={2}>
        <Box
          sx={{
            width: 100,
            height: 56,
            backgroundImage: `url(${image})`,
            backgroundPosition: "center",
            backgroundRepeat: "no-repeat",
            backgroundSize: "cover",
            borderRadius: "12px",
          }}
        />
        <Box>
          <Typography>{name}</Typography>
          <Typography fontSize="14px" color="#4F7A94">
            {address}
          </Typography>
        </Box>
      </Stack>
    </Paper>
  );
};

export default PlaygroundListItem;
