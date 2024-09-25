import React, { useEffect } from "react";
import { Outlet, useParams } from "react-router-dom";
import Header from "../components/PlaygroundOverview/Header";
import { useGetPlaygroundByIdMutation } from "../../state/api/backendApi";

const Playground = () => {
  const { id } = useParams();
  const [getPlaygroundById] = useGetPlaygroundByIdMutation();

  useEffect(() => {
    getPlaygroundById(id);
  }, []);

  return (
    <>
      <Header />
      <Outlet />
    </>
  );
};

export default Playground;
