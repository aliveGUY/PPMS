import { configureStore } from "@reduxjs/toolkit";
import { geoCodeApi } from "./geoCodeApi";
import { getCodeSlice } from "./geoCodeSlice";

const store = configureStore({
  reducer: {
    [geoCodeApi.reducerPath]: geoCodeApi.reducer,
    [getCodeSlice.name]: getCodeSlice.reducer,
  },
  middleware: (getDefaultMiddleware) =>
    getDefaultMiddleware().concat(geoCodeApi.middleware),
  devTools: process.env.NODE_ENV !== "production",
});

export default store;
