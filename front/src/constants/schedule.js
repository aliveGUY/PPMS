export const SESSION_PRACTICE = "SESSION_PRACTICE";
export const SESSION_FRIENDLY_MATCH = "SESSION_FRIENDLY_MATCH";
export const EVENT_COMPETITIVE_MATCH = "EVENT_COMPETITIVE_MATCH";
export const EVENT_CELEBRATION = "EVENT_CELEBRATION";

export const SCHEDULE_TYPES = [
  SESSION_PRACTICE,
  SESSION_FRIENDLY_MATCH,
  EVENT_COMPETITIVE_MATCH,
  EVENT_CELEBRATION,
];

export const REPEAT_ONLY_ONCE = "ONLY_ONCE";
export const REPEAT_DAILY = "DAILY";
export const REPEAT_WEEKLY = "WEEKLY";
export const REPEAT_MONTHLY = "MONTHLY";
export const REPEAT_YEARLY = "YEARLY";

export const ALLOWED_MONTH_DAYS = Array.from({ length: 28 }, (_, i) => i + 1);
export const MONTHS = [
  "January",
  "February",
  "March",
  "April",
  "May",
  "June",
  "July",
  "August",
  "September",
  "October",
  "November",
  "December",
];
