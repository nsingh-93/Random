#!/usr/bin/env ruby

# Simple program just to get used to functions in Ruby


=begin
 Takes an input string from teh user and another string
 of words to remove and prints out the first without words
 from the second string
=end
def remove_words(text, removes)
	words = text.split(" ")

	words_to_remove = []

	removes.split(" ").each do |item|
		words_to_remove << item
	end

	return_text = ""

	words.each do |word|
		return_text += "#{word} " unless words_to_remove.include?(word)
	end

	return return_text
end

puts defined? self.remove_words()

puts "Enter text:"
text = gets.chomp

puts "Enter words to remove:"
removes = gets.chomp

return_text = remove_words(text, removes)

print return_text