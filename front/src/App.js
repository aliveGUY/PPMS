import React from "react";
import { createBrowserRouter } from "react-router-dom";
import Home from "./presentation/pages/Home";
import Playground from "./presentation/pages/Playground";
import RegisterPlayground from "./presentation/pages/RegisterPlayground";
import Layout from "./presentation/components/Layout";
import Calendar from "./presentation/components/PlaygroundOverview/Calendar";
import History from "./presentation/components/PlaygroundOverview/History";
import Votings from "./presentation/components/PlaygroundOverview/Votings";

const router = createBrowserRouter([
  {
    path: "/",
    element: <Layout />,
    children: [
      {
        path: "/",
        element: <Home />,
      },
      {
        path: "playground/:id",
        element: <Playground />,
        children: [
          {
            index: true,
            element: <Calendar />,
          },
          {
            path: "history",
            element: <History />,
          },
          {
            path: "votings",
            element: <Votings />,
          },
        ],
      },
      {
        path: "playground/new",
        element: <RegisterPlayground />,
      },
    ],
  },
]);

export default router;
