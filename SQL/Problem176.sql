-- ============================================
-- Purpose: Find the second highest distinct salary
-- Table: Employee (columns: id INT, salary INT)
-- Assumptions:
--   - Each employee has a unique ID
--   - Salaries may repeat
--   - If there's no second highest salary, return NULL
-- ============================================

-- Step-by-step explanation:
-- 1. SELECT MAX(salary) FROM Employee
--    → Finds the highest salary in the table.
-- 2. WHERE salary < (SELECT MAX(salary) FROM Employee)
--    → Filters out the highest salary, leaving only lower ones.
-- 3. SELECT MAX(salary) FROM the filtered result
--    → Finds the highest among the remaining salaries, which is the second highest.

SELECT MAX(salary) AS SecondHighestSalary
FROM Employee
WHERE salary < (
    SELECT MAX(salary) FROM Employee
);

-- ============================================
-- Result Behavior:
-- - If salaries are: [3000, 5000, 7000], result is 5000
-- - If salaries are: [7000, 7000], result is NULL (no second distinct salary)
-- - If salaries are: [7000], result is NULL
-- ============================================
