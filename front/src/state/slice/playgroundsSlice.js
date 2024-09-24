import { createSlice } from "@reduxjs/toolkit";
import { backendApi } from "../api/backendApi";

export const playgroundsSlice = createSlice({
  name: "playgrounds",
  initialState: {
    playgrounds: [],
    scope: "all",
    searchParams: {},
  },
  reducers: {
    rememberSearchParams: (state, { payload }) => {
      state.searchParams = payload
      return state;
    },
  },
  extraReducers: (builder) => {
    builder.addMatcher(
      backendApi.endpoints.getPlaygrounds.matchFulfilled,
      (state, { payload }) => {
        state.playgrounds = payload.playgrounds;
        state.scope = payload.scope;
        return state;
      }
    );
  },
});

export const { rememberSearchParams } = playgroundsSlice.actions;
