import { createApi, fetchBaseQuery } from "@reduxjs/toolkit/query/react";

export const backendApi = createApi({
  reducerPath: "backendApi",
  baseQuery: fetchBaseQuery({
    baseUrl: "http://localhost:8080",
  }),
  endpoints: (builder) => ({
    getPlaygrounds: builder.mutation({
      query: ({ address, city, province, country }) => {
        const params = new URLSearchParams();

        if (address) params.append("address", address);
        if (city) params.append("city", city);
        if (province) params.append("province", province);
        if (country) params.append("country", country);

        return `/api/playground?${params.toString()}`;
      },
    }),

    registerPlayground: builder.mutation({
      query: (playgroundData) => ({
        url: "/api/playground",
        method: "POST",
        body: playgroundData,
      }),
    }),

    getPlaygroundById: builder.mutation({
      query: (id) => `/api/playground/${id}`,
    }),
  }),
});

export const {
  useGetPlaygroundsMutation,
  useRegisterPlaygroundMutation,
  useGetPlaygroundByIdMutation,
} = backendApi;
