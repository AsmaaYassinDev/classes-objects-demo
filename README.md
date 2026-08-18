# Classes & Objects — Practice Exercise

## Question 1 — Explain It to a Non-Technical Person

How would you explain the difference between a **Class** and an **Object**
to someone who has never programmed before?

Use an everyday example.

---

## Question 2 — Explain It to a Client

A client with no programming knowledge asks:

> "We have many students in our system. Why can't we just create separate
> variables for each student's name, age, and course?"

How would you explain the benefit of using a **Class** instead?

Explain it without using programming terminology.

---

## Question 3 — Design a Bank Account Class

Note: Question 3 will take significantly longer than Questions 1–2 — plan your time accordingly.

### The Problem

A bank needs a simple program to manage customer bank accounts.

Each bank account has an **account number**, an **owner name**, and a
**balance**. A customer should be able to **deposit money**, **withdraw
money**, and **check their balance**.

The bank will have many accounts, so we want to create a `BankAccount`
class and use it to create different account objects — the same way we
created different `Cake` objects from one `Cake` class.

### Your Task

Before writing any code, identify:

1. **What is the Class?**
2. **What are the Objects?**
3. **What Fields does the class need?**
4. **What Methods does the class need?**
5. **What information should the Constructor receive?**

### UML

Draw a UML diagram for your `BankAccount` class.

Include:
- Class name
- Fields
- Constructor
- Methods

### Coding

Create the `BankAccount` class based on your UML diagram.

Keep it simple, the same way we built the `Cake` class:
- All fields can be `public`.
- Use `int` for the balance (no decimals needed for this exercise).
- `Deposit` and `Withdraw` just need to add or subtract the amount — you
  don't need to check for errors like negative amounts or insufficient
  funds. (If you finish early and want an extra challenge, try adding
  that yourself!)

Your program should create at least **two objects** and demonstrate that
each object has its own data and balance.

---

## Acceptance Criteria

- [ ] `BankAccount` class created.
- [ ] Fields for account number, owner name, and balance.
- [ ] Constructor created.
- [ ] `Deposit()` method created.
- [ ] `Withdraw()` method created.
- [ ] `GetBalance()` method created.
- [ ] At least two objects created.
- [ ] Each object has its own balance.
- [ ] Program compiles and runs successfully.
- [ ] UML diagram completed before coding.
