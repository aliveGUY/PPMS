import { createApi, fetchBaseQuery } from "@reduxjs/toolkit/query/react";

export const backendApi = createApi({
  reducerPath: "backendApi",
  baseQuery: fetchBaseQuery({
    baseUrl: "http://localhost:8080",
  }),
  endpoints: (builder) => ({
    getAllPlaygrounds: builder.query({
      query: () => "/api/playground",
    }),
  }),
});

export const { useGetAllPlaygroundsQuery } = backendApi;
