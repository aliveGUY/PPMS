import { configureStore } from "@reduxjs/toolkit";
import { geoCodeApi } from "./api/geoCodeApi";
import { backendApi } from "./api/backendApi";
import { getCodeSlice } from "./slice/geoCodeSlice";

const store = configureStore({
  reducer: {
    [geoCodeApi.reducerPath]: geoCodeApi.reducer,
    [backendApi.reducerPath]: backendApi.reducer,
    [getCodeSlice.name]: getCodeSlice.reducer,
  },
  middleware: (getDefaultMiddleware) =>
    getDefaultMiddleware().concat(geoCodeApi.middleware, backendApi.middleware),
  devTools: process.env.NODE_ENV !== "production",
});

export default store;
