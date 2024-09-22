import { createApi, fetchBaseQuery } from "@reduxjs/toolkit/query/react";

export const backendApi = createApi({
  reducerPath: "backendApi",
  baseQuery: fetchBaseQuery({
    baseUrl: "http://localhost:8080",
  }),
  endpoints: (builder) => ({
    getPlaygrounds: builder.mutation({
      query: ({ country, city, state, title }) => {
        const params = new URLSearchParams();

        if (title) params.append("title", title);
        if (city) params.append("city", city);
        if (state) params.append("state", state);
        if (country) params.append("country", country);

        return `/api/playground?${params.toString()}`;
      },
    }),
  }),
});

export const { useGetPlaygroundsMutation } = backendApi;
