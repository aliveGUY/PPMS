import React, { useCallback, useEffect, useState } from "react";
import {
  Button,
  FormControl,
  IconButton,
  InputLabel,
  MenuItem,
  Modal,
  OutlinedInput,
  Paper,
  Select,
  Stack,
  Typography,
} from "@mui/material";
import { useDispatch, useSelector } from "react-redux";
import CloseIcon from "@mui/icons-material/Close";
import EditIcon from "@mui/icons-material/Edit";
import {
  closeScheduleModal,
  initialScheduleState,
} from "../../../../state/slice/scheduleModalSlice";
import { TimeField } from "@mui/x-date-pickers";
import {
  REPEAT_DAILY,
  REPEAT_MONTHLY,
  REPEAT_ONLY_ONCE,
  REPEAT_WEEKLY,
  REPEAT_YEARLY,
} from "../../../../constants/schedule";
import { useForm, Controller, FormProvider } from "react-hook-form";
import RepeatInputFactory from "./RepeatInputFactory";
import dayjs from "dayjs";
import utc from "dayjs/plugin/utc";

dayjs.extend(utc);

const ScheduleModal = () => {
  const dispatch = useDispatch();
  const modalState = useSelector((state) => state.scheduleModalState);
  const methods = useForm({ defaultValues: initialScheduleState });
  const {
    handleSubmit,
    control,
    formState: { errors },
  } = methods;

  const [isEdit, setIsEdit] = useState(false);
  const [repeat, setRepeat] = useState(REPEAT_ONLY_ONCE);

  const isPurposeEdit = "edit" === modalState.purpose;
  const isPurposeCreate = "create" === modalState.purpose;
  const enableForm = isEdit || isPurposeCreate;

  const closeModal = useCallback(() => {
    setIsEdit(false);
    dispatch(closeScheduleModal());
  }, []);

  const toggleEdit = () => {
    setIsEdit((prev) => !prev);
  };

  const handleRepeatChange = (e) => {
    setRepeat(e.target.value);
  };

  const onSubmit = (data) => console.log(data);

  useEffect(() => {
    if (modalState.data) {
      methods.reset({
        title: modalState.data.title,
        startAt: modalState.data.startAt
          ? dayjs.utc(modalState.data.startAt)
          : null,
        finishAt: modalState.data.finishAt
          ? dayjs.utc(modalState.data.finishAt)
          : null,
        repeat: modalState.data.repeat,
        onlyOnce: modalState.data.onlyOnce,
        weekly: modalState.data.weekly,
        monthly: modalState.data.monthly,
        yearly: modalState.data.yearly,
      });
    }
  }, [modalState.data, methods]);

  return (
    <Modal open={modalState.opened}>
      <Paper
        sx={{
          width: 310,
          padding: 2,
          position: "absolute",
          top: "50%",
          left: "50%",
          transform: "translate(-50%, -50%)",
        }}
      >
        <Stack
          direction="row"
          justifyContent="space-between"
          alignItems="center"
          mb={3}
        >
          <Typography>Session</Typography>
          <Stack direction="row">
            {isPurposeEdit && (
              <IconButton onClick={toggleEdit}>
                <EditIcon />
              </IconButton>
            )}
            <IconButton onClick={closeModal}>
              <CloseIcon />
            </IconButton>
          </Stack>
        </Stack>

        <FormProvider {...methods}>
          <form onSubmit={handleSubmit(onSubmit)}>
            <Stack spacing={2}>
              <Controller
                name="title"
                control={control}
                disabled={!enableForm}
                render={({ field }) => (
                  <FormControl>
                    <InputLabel htmlFor="title">Title</InputLabel>
                    <OutlinedInput id="title" label="Title" {...field} />
                  </FormControl>
                )}
              />

              <Controller
                name="startAt"
                control={control}
                disabled={!enableForm}
                render={({ field: { onChange, value, ...field } }) => (
                  <TimeField
                    label="Start at"
                    format="HH:mm"
                    value={value ? dayjs(value) : null}
                    onChange={(newValue) => {
                      onChange(newValue);
                    }}
                    {...field}
                  />
                )}
              />

              <Controller
                name="finishAt"
                control={control}
                disabled={!enableForm}
                render={({ field: { onChange, value, ...field } }) => (
                  <TimeField
                    label="Finish at"
                    format="HH:mm"
                    value={value ? dayjs(value) : null}
                    onChange={(newValue) => {
                      onChange(newValue);
                    }}
                    {...field}
                  />
                )}
              />

              <Controller
                name="repeat"
                control={control}
                disabled={!enableForm}
                onChange={handleRepeatChange}
                render={({ field: { onChange, ...field } }) => (
                  <FormControl>
                    <InputLabel id="repeat">Repeat</InputLabel>
                    <Select
                      labelId="repeat"
                      label="Repeat"
                      onChange={(e) => {
                        onChange(e);
                        handleRepeatChange(e);
                      }}
                      {...field}
                    >
                      <MenuItem value={REPEAT_ONLY_ONCE}>Only once</MenuItem>
                      <MenuItem value={REPEAT_DAILY}>Daily</MenuItem>
                      <MenuItem value={REPEAT_WEEKLY}>Weekly</MenuItem>
                      <MenuItem value={REPEAT_MONTHLY}>Monthly</MenuItem>
                      <MenuItem value={REPEAT_YEARLY}>Yearly</MenuItem>
                    </Select>
                  </FormControl>
                )}
              />

              <RepeatInputFactory repeat={repeat} disabled={!enableForm} />

              {enableForm && (
                <Button type="submit" variant="contained">
                  Submit
                </Button>
              )}
            </Stack>
          </form>
        </FormProvider>
      </Paper>
    </Modal>
  );
};

export default ScheduleModal;
