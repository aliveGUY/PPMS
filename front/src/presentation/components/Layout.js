import React from "react";
import { Box } from "@mui/material";
import { Outlet } from "react-router-dom";
import Navbar from "./Navbar";

const Layout = () => {
  return (
    <Box maxWidth={1400} px={2} mx="auto">
      <Navbar />
      <Outlet />
    </Box>
  );
};

export default Layout;
