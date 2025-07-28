# 🧮 Parentheses Balance Library

A simple, testable C# class library that validates whether a string contains well-ordered and balanced parentheses (or brackets). This library uses a stack-based approach and supports various bracket types including `()`, `{}`, `[]`, `<>`, and even `"`.

---

## ✨ Features

- ✅ Validates parentheses, brackets, and braces in any order
- ✅ Ignores non-bracket characters (e.g., in math expressions)
- ✅ Supports common symbols: `()`, `{}`, `[]`, `<>`, `""`
- ✅ Clean, reusable `public static` method
- ✅ Fully covered by unit tests with xUnit
- ✅ Lightweight and dependency-free

---

## 🔧 Usage

```csharp
using ParenthesesBalanceLibrary.ParenthesesChecker;

bool isValid = ParenthesesChecker.IsParenthesesBalanced("({[<>]})");
// isValid == true
```

## 📦 Supported Brackets

The library currently supports:
Type	Example
Parentheses	(a + b)
Braces	{key: value}
Square Brackets	[1, 2, 3]
Angle Brackets	<div>
Quotes (symmetric)	"text" (limited support)

🧪 Running Tests

This repo includes a full xUnit test suite under ParenthesesBalanceLibrary.Tests.

To run tests:
```
dotnet test
```

All edge cases are covered, including:

    Nested structures

    Mismatched or out-of-order brackets

    Extra openers/closers

    Empty strings


## 📁 Project Structure
```
/ParenthesesBalanceLibrary
    └── ParenthesesChecker.cs  // Core logic

/ParenthesesBalanceLibrary.Tests
    └── ParenthesesCheckerTests.cs // xUnit test suite
```

🤝 Contributing

Feel free to fork, open issues, or submit pull requests with:

    Additional bracket support (like single quotes, backticks)

    Language localization

    Performance improvements

📜 License

MIT — free to use, modify, and share.
🧠 Author

Built by Oche @TheNigerianNerd Edache, a life-long learner and software engineer
