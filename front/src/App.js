import React from "react";
import { createBrowserRouter } from "react-router-dom";
import Home from "./presentation/pages/Home";
import Layout from "./presentation/components/Layout";
const router = createBrowserRouter([
  {
    path: "/",
    element: <Layout />,
    children: [
      {
        path: "/",
        element: <Home />,
      },
    ],
  },
]);

export default router;
