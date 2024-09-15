import { createSlice } from "@reduxjs/toolkit";
import { geoCodeApi } from "../api/geoCodeApi";

export const getCodeSlice = createSlice({
  name: "geoCodeData",
  initialState: {
    addressSuggestions: [],
    addressInputValue: "",
  },
  reducers: {
    rememberAddressInputValue: (state, { payload }) => {
      state.addressInputValue = payload;
    },
  },
  extraReducers: (builder) => {
    builder
      .addMatcher(
        geoCodeApi.endpoints.geocode.matchFulfilled,
        (state, { payload }) => {
          const addressSuggestions = payload.items.map(
            (address) => address.title
          );
          state.addressSuggestions = addressSuggestions;
          return state;
        }
      )
      .addMatcher(
        geoCodeApi.endpoints.geocode.matchRejected,
        (state, action) => {
          state.addressSuggestions = [];
          return state;
        }
      );
  },
});

export const { rememberAddressInputValue } = getCodeSlice.actions;
