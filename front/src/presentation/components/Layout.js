import React from "react";
import { Box } from "@mui/material";
import { Outlet } from "react-router-dom";

const Layout = () => {
  return (
    <Box maxWidth={1400} px={2} mx="auto">
      <div>Navigation</div>
      <Outlet />
    </Box>
  );
};

export default Layout;
