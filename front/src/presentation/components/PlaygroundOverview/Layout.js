import React from "react";
import { Outlet } from "react-router-dom";
import Header from "./Header";

const PlaygroundLayout = () => {
  return (
    <>
      <Header />
      <Outlet />
    </>
  );
};

export default PlaygroundLayout;
