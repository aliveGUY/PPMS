export const convertToTimeFormat = (hour) => {
  // Ensure the hour is between 1 and 24
  if (hour < 1 || hour > 24) {
    throw new Error("Hour must be between 1 and 24");
  }

  // Convert to 00:00 format
  const formattedHour = String(hour % 24).padStart(2, "0"); // Handle 24 as 00
  const formattedTime = `${formattedHour}:00`;
  return formattedTime;
};

export const mapSchedule = (schedule) =>
  schedule.reduce((acc, session) => {
    const startHour = getHour(session.startAt);
    const endHour = getHour(session.finishAt);

    for (let covered = startHour + 1; covered < endHour; covered++)
      acc[covered] = { isCovered: true };

    acc[startHour] = session;
    return acc;
  }, {});

export const getHour = (dateString) => {
  if (!dateString) return;
  return new Date(dateString).getUTCHours();
};
