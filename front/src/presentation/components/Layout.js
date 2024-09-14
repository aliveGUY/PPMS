import React from "react";
import { Outlet } from "react-router-dom";

const Layout = () => {
  return (
    <div>
      <div>Navigation</div>
      <Outlet />
      <div>Footer</div>
    </div>
  );
};

export default Layout;
