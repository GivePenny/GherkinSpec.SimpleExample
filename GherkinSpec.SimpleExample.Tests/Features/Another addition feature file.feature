Feature: Add two numbers
	In order to count how many apples I've collected
	As an apple-hoarder
	I want to add two numbers together

Scenario: Add two numbers together
	Given I have 7 apples
	When I add 8 more
	Then the result should be 14
	