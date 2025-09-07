-- ============================================
-- Purpose: Report first name, last name, city, and state of each person
-- Tables:
--   - Person (personId, firstName, lastName)
--   - Address (addressId, personId, city, state)
-- Requirements:
--   - Include all persons, even if they have no address
--   - Return NULL for city/state if address is missing
-- ============================================

-- Step-by-step explanation:
-- 1. Use LEFT JOIN to include all rows from Person
--    → Ensures persons without addresses are still shown
-- 2. Join on personId, which links both tables
-- 3. Select required columns from both tables

SELECT 
    p.firstName,     -- First name from Person table
    p.lastName,      -- Last name from Person table
    a.city,          -- City from Address table (may be NULL)
    a.state          -- State from Address table (may be NULL)
FROM Person p
LEFT JOIN Address a
    ON p.personId = a.personId;

-- ============================================
-- Result Behavior:
-- - If a person has an address, city/state are shown
-- - If a person has no address, city/state are NULL
-- - Output includes all persons, regardless of address
-- ============================================
