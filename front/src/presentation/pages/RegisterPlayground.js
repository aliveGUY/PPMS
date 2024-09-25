import {
  Button,
  FormControl,
  InputLabel,
  OutlinedInput,
  Stack,
  Typography,
} from "@mui/material";
import { useNavigate } from "react-router-dom";
import React, { useCallback, useEffect } from "react";
import { Controller, FormProvider, useForm } from "react-hook-form";
import { useDispatch, useSelector } from "react-redux";
import { useGeocodeMutation } from "../../state/api/geoCodeApi";
import {
  clearAddressState,
  rememberAddressInputValue,
} from "../../state/slice/geoCodeSlice";
import AddressSuggestions from "../common/AddressSuggestions";
import { useRegisterPlaygroundMutation } from "../../state/api/backendApi";

const RegisterPlayground = () => {
  const searchParams = useSelector((state) => state.playgrounds.searchParams);

  const methods = useForm({
    defaultValues: {
      address: searchParams.address,
    },
  });
  const {
    handleSubmit,
    control,
    formState: { errors },
  } = methods;

  const [geocode] = useGeocodeMutation();
  const [registerPlayground, { isLoading, isSuccess }] =
    useRegisterPlaygroundMutation();

  const dispatch = useDispatch();
  const navigate = useNavigate();

  const handleInputChange = useCallback((e) => {
    geocode(e.target.value);
    dispatch(rememberAddressInputValue(e.target.value));
  }, []);

  const onSubmit = (data) => {
    const playgroundDto = {
      name: data.title,
      address: data.address,
      street: searchParams.street,
      city: searchParams.city,
      province: searchParams.province,
      country: searchParams.country,
      images: [],
    };
    registerPlayground(playgroundDto);
  };

  useEffect(() => {
    return () => {
      dispatch(clearAddressState());
    };
  }, []);

  useEffect(() => {
    methods.reset({
      address: searchParams.address,
    });
  }, [searchParams, methods]);

  useEffect(() => {
    if (isSuccess) navigate("/");
  }, [isSuccess]);

  return (
    <Stack py={3}>
      <Typography variant="h5">Register Playground</Typography>
      <FormProvider {...methods}>
        <form onSubmit={handleSubmit(onSubmit)}>
          <Stack py={2}>
            <Controller
              name="address"
              control={control}
              disabled={isLoading}
              render={({ field: { onChange, value, ...field } }) => (
                <Stack sx={{ position: "relative" }}>
                  <FormControl>
                    <InputLabel htmlFor="address">Address</InputLabel>
                    <OutlinedInput
                      id="address"
                      label="Address"
                      value={value}
                      onChange={(newValue) => {
                        onChange(newValue);
                        handleInputChange(newValue);
                      }}
                      {...field}
                    />
                  </FormControl>
                  <AddressSuggestions />
                </Stack>
              )}
            />
          </Stack>

          <Stack py={2}>
            <Controller
              name="title"
              control={control}
              disabled={isLoading}
              render={({ field }) => (
                <FormControl>
                  <InputLabel htmlFor="title">Title</InputLabel>
                  <OutlinedInput id="title" label="Title" {...field} />
                </FormControl>
              )}
            />
          </Stack>

          <Button type="submit" variant="contained" disabled={isLoading}>
            Submit
          </Button>
        </form>
      </FormProvider>
    </Stack>
  );
};

export default React.memo(RegisterPlayground);
