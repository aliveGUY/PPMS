import React from "react";
import AddressInput from "../components/AddressInput";
import { useGetAllPlaygroundsQuery } from "../../state/api/backendApi";
const Home = () => {
  const { data } = useGetAllPlaygroundsQuery();
  console.log({ data });

  return (
    <div>
      <AddressInput />
    </div>
  );
};

export default Home;
