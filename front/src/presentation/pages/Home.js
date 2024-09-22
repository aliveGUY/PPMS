import React, { useEffect } from "react";
import Header from "../components/Home/Header";
import PlaygroundsList from "../components/Home/PlaygroundsList";
import { useGetPlaygroundsMutation } from "../../state/api/backendApi";

const Home = () => {
  const [getPlaygrounds] = useGetPlaygroundsMutation();

  useEffect(() => {
    getPlaygrounds({});
  }, []);

  return (
    <div>
      <Header />
      <PlaygroundsList />
    </div>
  );
};

export default Home;
