all:
	mcs *.cs
	cd ./Entities/Player
	mcs *.cs
	cd ./Entities/Enemies
	mcs *.cs
	cd ./Scenarios/Fight
	mcs *.cs
