library("reshape2")
library("ggplot2")
library("plyr")

results = read.csv2("Benchmark\\bin\\Release\\results.csv", sep=';',dec='.',row.names = NULL)
results$Version = paste(results$Solution, "(", results$Mode, ")")
updates = subset(results, Phase=="Update")
initials = subset(results, Phase=="Initial")
averages.updates = ddply(updates, c("Size", "Version"), summarize, Time=mean(Time) / 10000)
averages.initial = ddply(initials, c("Size", "Version"), summarize, Time=mean(Time) / 10000)

bwTheme <- theme(text=element_text(family="Helvetica", size=16),
                 panel.background = element_rect(fill="#FFFFFF"),
                 legend.position="bottom",
                 legend.direction="horizontal",
                 panel.grid.major = element_line(size=0.3, colour="#333333"),
                 panel.grid.minor = element_line(size=0.15, colour="#CCCCCC"),
                 axis.text.x = element_text(colour="black"),
                 axis.text.y = element_text(colour="black")
)

plot = ggplot(averages.initial, aes_string(x = "Size", y = "Time")) + geom_line(aes_string(group = "Version", colour = "Version"), size=1)
plot = plot + geom_point(aes_string(shape = "Version", colour="Version"), size=3)
plot = plot + ylab("Time [ms]") + xlab("Size")
plot = plot + bwTheme
plot = plot + scale_x_log10(breaks = 2^seq(0,6), labels=2^seq(0,6))
plot = plot + scale_y_log10()
ggsave(plot, filename = "initials.pdf", width=10, height=5, dpi=192)

plot = ggplot(averages.updates, aes_string(x = "Size", y = "Time")) + geom_line(aes_string(group = "Version", colour = "Version"), size=1)
plot = plot + geom_point(aes_string(shape = "Version", colour="Version"), size=3)
plot = plot + ylab("Time [ms]") + xlab("Size")
plot = plot + bwTheme
plot = plot + scale_x_log10(breaks = 2^seq(0,6), labels=2^seq(0,6))
plot = plot + scale_y_log10()
ggsave(plot, filename = "updates.pdf", width=10, height=5, dpi=192)