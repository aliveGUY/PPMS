import { createSlice } from "@reduxjs/toolkit";
import { REPEAT_ONLY_ONCE } from "../../constants/schedule";

export const initialScheduleState = {
  title: null,
  startAt: null,
  finishAt: null,
  repeat: REPEAT_ONLY_ONCE,
  onlyOnce: null,
  weekly: null,
  monthly: null,
  yearly: null,
};

export const scheduleModalSlice = createSlice({
  name: "scheduleModalState",
  initialState: {
    opened: false,
    purpose: null,
    data: initialScheduleState,
  },
  reducers: {
    openEditScheduleModal: (state, { payload }) => {
      state.opened = true;
      state.purpose = "edit";
      state.data = { ...initialScheduleState, ...payload };
    },

    openCreateScheduleModal: (state) => {
      state.opened = true;
      state.purpose = "create";
      state.data = initialScheduleState;
    },

    closeScheduleModal: (state) => {
      state.opened = false;
      state.data = initialScheduleState;
    },
  },
});

export const {
  closeScheduleModal,
  openEditScheduleModal,
  openCreateScheduleModal,
} = scheduleModalSlice.actions;
