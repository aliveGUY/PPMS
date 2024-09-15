import { createApi, fetchBaseQuery } from "@reduxjs/toolkit/query/react";

console.log("test", process.env);

export const geoCodeApi = createApi({
  reducerPath: "geoCodeApi",
  baseQuery: fetchBaseQuery({
    baseUrl: "https://geocode.search.hereapi.com/v1/",
  }),
  endpoints: (builder) => ({
    geocode: builder.mutation({
      query: (query) => ({
        url: `geocode?q=${query}&apiKey=${process.env.REACT_APP_HERE_API_KEY}`,
        method: "GET",
      }),
    }),
  }),
});

export const { useGeocodeMutation } = geoCodeApi;
