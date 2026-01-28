# Parking Garage Change Machine — Kata Walkthrough

This kata explores how to evolve an algorithm as requirements change across multiple phases.  
Each phase introduces a new constraint that forces you to rethink your approach, culminating in a general, maintainable solution.

---

## Phase 1 — Basic Change Making

**Requirements**
- Accept an amount due and an amount paid.
- Return the correct change as a list of coin denominations.
- Use U.S. coins: **25¢, 10¢, 5¢, 1¢**.
- Always return the **fewest coins possible**.

**Notes**
- With these denominations, a **greedy algorithm is optimal**.
- Implementation is straightforward: repeatedly subtract the largest coin that fits.

---

## Phase 2 — “Discourage Pennies”

**New Requirement**
> “We want to discourage use of pennies. Only use pennies if absolutely necessary.”

**Interpretation**
- The garage no longer wants to stock pennies.
- To avoid returning 1¢ coins, the machine **rounds the change up to the nearest 5¢**.
- Use denominations: **25¢, 10¢, 5¢**.

**Notes**
- Greedy still works because all denominations are multiples of 5.
- Rounding ensures no pennies are ever returned.

---

## Phase 3 — Introduce a 12¢ Coin

**New Requirement**
> The garage introduces a **12¢ coin** and wants the algorithm to adapt without rewriting everything.

**Implications**
- The 12¢ coin **breaks the greedy algorithm**.
- Requirements from earlier phases still apply:
  - No pennies.
  - Round change up to nearest 5¢.
- We now need a **general algorithm** that works for any coin set.

---

## Solution

To support evolving coin sets without rewriting logic, the algorithm was refactored to use **bottom-up dynamic programming**:

- Computes the optimal (fewest coins) combination for any target amount.
- Works with any set of denominations.
- Cleanly handles the 12¢ coin and any future additions.
- Extracted into a reusable helper method for clarity and maintainability.

---

## Key Takeaways

- **Requirements evolve; algorithms must adapt.**
- Greedy is not always optimal.
- Dynamic programming provides a **general, maintainable** solution.
- Clean tests and clear reasoning matter as much as code.
- Designing for change is a core skill in consulting-style development.

---
