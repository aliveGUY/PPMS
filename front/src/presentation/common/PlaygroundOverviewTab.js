import React, { useCallback } from "react";
import { Button, Typography } from "@mui/material";
import { useLocation, useNavigate } from "react-router-dom";

const PlaygroundOverviewTab = ({ to, text }) => {
  const navigate = useNavigate();
  const location = useLocation();

  const isActive = location.pathname === to;

  const redirect = useCallback(() => {
    navigate(to);
  }, [navigate]);

  return (
    <Button
      sx={{
        flex: 1,
        height: 53,
        borderBottom: isActive ? "3px solid #1976d2" : "3px solid #E5E8EB",
        borderRadius: 0,
      }}
      onClick={redirect}
    >
      <Typography
        fontWeight={isActive ? 700 : "normal"}
        color={isActive ? "black" : "#4F7A94"}
      >
        {text}
      </Typography>
    </Button>
  );
};

export default PlaygroundOverviewTab;
