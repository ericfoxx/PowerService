<h1 align="center">
  PowerService
  <br>
</h1>

<h4 align="center">A mathematical exploration of the relationships between powers.</h4>

<h3>Mathematical Foundation</h3>

We can define a square of a number $x$ in terms of itself and the previous number, which we denote $v=x-1$. Thus, $x^2=v^2+v+x$. Therefore, we can iterate through all squares until we hit the `uint` limit. While this is trivially accomplished in C# with `var xSquared = x * x`, this project aims to explore these relationships further by expanding our powers out to cubes and beyond.

Similarly, we can define the cube of a number $x$, using $v=x-1$, as $x^3=v^3+v^2+x^2+vx$. The fourth power can be described similarly as $x^4=v^4+x^3+v^3+vx^2+xv^2$. Note, the fourth only holds when $x>2$.

<p align="center">
  <a href="#key-features">Key Features</a> •
  <a href="#how-to-use">How To Use</a> •
  <a href="#wish-list">Wish List</a> •
  <a href="#license">License</a>
</p>

## Key Features

* Flexibility
  - Either generate powers individually (squares, cubes, etc.) or all at once.
  - Generate cubes up to a certain value, or until you hit the unsigned integer limit.
* Persistence
  - A `JSON` file of the powers will be saved for future runs.

## How To Use

To clone and run this application, you'll need [Git](https://git-scm.com) and the .Net 8 [runtime](https://nodejs.org/en/download/) installed on your computer. From your command line:

```bash
# Clone this repository
$ git clone https://github.com/ericfoxx/PowerService

# Go into the repository
$ cd PowerService

# Run the tests
$ dotnet test

# Run the app
$ dotnet run
```

## Wish List

* BigNumber support
* Logging with levels
* Performance checking with logging

## License

GPL-2.0