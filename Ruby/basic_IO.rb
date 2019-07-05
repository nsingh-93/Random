#!/usr/bin/env ruby

print "What is your first name? "

name = gets.chomp

name.capitalize!

puts "Hello #{name}"