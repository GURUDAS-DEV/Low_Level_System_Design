DRY : Do not Repeat Yourself

#Explanation
- Each piece of knowledge should exactly lives once in your code base at exactly one place, If you're saying something is being repeatedly for more than three times then that is the violation of DRY principal
- If you are able to see that any business logic are being repeatedly in the code then that's wrong you have to Convert that particular thing into a single source of truth so that Debugging could be easy, modifying or extension could become easy overhead would reduced

So how debugging will become easy or extension will become easy if we follow dry principle : 

1) If we follow DRY principle, So our repetitive logic should be in a single source Of truth, We can't repeat them, So this means if somehow we have to extend anything in future we can easily add there and the class that has been using that particular thing will Have almost no effect
2) Suppose there is a Logic that is being used five times in your program or maybe 10 times or 20 time in your program but somehow in the future you have to update that particular logic So you have to change that thing 20 different times in your code that would become so hard to update That's why using the principle could solve this problem

Sometime repeativeness is not bad, Because duplication is far cheaper Then wrong abstraction

Do not extract shared code too early. Let duplication reveal itself first. Abstractions created too soon can be misleading or hard to maintain.
