Feature: LendAnItem
	In order to keep track of my stuff
	And not lose it to robbing bastards
	I want to maintain details of loans online

Scenario: Add an entry for an item
	Given that I want to enter details of a loaned item
	And I have navigated to the page for entering loaned items
	When I enter item description as "Half Inch Drill Bit"
	And I enter name of person as "Boring Bastard"
	And I click on OK button
	Then I see a submission confirmation message
